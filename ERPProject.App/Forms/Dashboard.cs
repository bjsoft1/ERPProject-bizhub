using ERPProject.App.Dtos;
using ERPProject.App.Utilities;
using ERPProject.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using ERPProject.Controls.Extensions;
using System.Windows.Forms;
using ERPProject.Model;
using Dapper;
using System.Reflection;

namespace ERPProject.App.Forms
{
    public partial class Dashboard : ERPForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Get all data-grided view datas.
            var query = @"select O.Id, C.CustomerName, C.CustomerAddress, C.CustomerMobile, U.FullName as OrderBy, O.TotalAmount, O.OrderStatus
From [Order].[Orders] O 
Inner Join [Person].[Customers] C On C.Id = O.CustomerId
Inner Join [Person].[Users] U On U.Id = O.CreatorUserId";
            _orderList = ERPSqlHelper.ExcuteEnumerable<OrderListingDto>(query);
            swithchParent(_pendingList, _orderList.Where(x=> x.OrderStatus == ESaleOrderStatus.Pending || x.OrderStatus == ESaleOrderStatus.Rejected));
        }
        // Gloal Datagride view datasource
        IEnumerable<OrderListingDto> _orderList;

        #region main Menu Click Events
        private void _createProduct_Click(object sender, EventArgs e)
        {

        }
        private void _createCustomer_Click(object sender, EventArgs e)
        {

        }
        private void _createOrder_Click(object sender, EventArgs e)
        {

        }
        #endregion main Menu Click Events

        /// <summary>
        /// Enabled or disabled buttons according to needs
        /// </summary>
        /// <param name="isEnabledAproved"></param>
        /// <param name="isEnabledReject"></param>
        void updateButtonStatus(bool isEnabledAproved, bool isEnabledReject)
        {
            _btnApprove.Enabled = isEnabledAproved;
            _btnReject.Enabled = isEnabledReject;
        }

        /// <summary>
        /// Enabled or disabled buttons according to orderDTO object
        /// </summary>
        /// <param name="orderListingDto"></param>
        void updateButtonStatus(OrderListingDto orderListingDto)
        {
            if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.Pending)
                updateButtonStatus(true, true);
            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.Rejected)
                updateButtonStatus(true, false);

            else if (orderListingDto.OrderStatus == Model.ESaleOrderStatus.SaleDepartmentApproved)
                updateButtonStatus(true, true);
            else if (orderListingDto.OrderStatus == Model.ESaleOrderStatus.SaleDepartmentRejected)
                updateButtonStatus(true, false);

            else if (orderListingDto.OrderStatus == Model.ESaleOrderStatus.AccountDepartmentApproved)
                updateButtonStatus(true, true);
            else if (orderListingDto.OrderStatus == Model.ESaleOrderStatus.AccountDepartmentRejected)
                updateButtonStatus(true, false);

            else if (orderListingDto.OrderStatus == Model.ESaleOrderStatus.FinalDepartmentApproved)
                updateButtonStatus(false, true);
            else if (orderListingDto.OrderStatus == Model.ESaleOrderStatus.FinalDepartmentRejected)
                updateButtonStatus(true, false);
        }
        
        /// <summary>
        /// When Try to paint in cell then update Enum variable value into string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var orderListingDto = ((List<OrderListingDto>)dataGridView1.DataSource)[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["OrderStatus"].Index && e.RowIndex >= 0)
            {
                e.Value = EnumExtension.GetDescriptionText(orderListingDto.OrderStatus);
            }
        }

        /// <summary>
        /// New Order create button click enent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _addOrder_Click(object sender, EventArgs e)
        {
            var form = new AddUpdateOrder();
            form.ShowDialog();
        }

        /// <summary>
        /// Try to make only one datagrided veiw for all panels.
        /// this method helps to mange low memory consume.
        /// </summary>
        /// <param name="newParent"></param>
        /// <param name="datasource"></param>
        void swithchParent(Control newParent, IEnumerable<OrderListingDto> datasource)
        {
            // find current panel or datagrided veiw.
            var parent = dataGridView1.Parent;
            
            // Remove from old parent
            parent.Controls.Remove(dataGridView1);
            
            // adding into current index parent
            newParent.Controls.Add(dataGridView1);
            
            // referesing data according to visible panel
            //TODO: Filter from server side.
            dataGridView1.DataSource = datasource.ToList();
            dataGridView1.Refresh();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefereshPanel(tabControl1.SelectedIndex);
        }
        /// <summary>
        /// Update Panel data-gride view and data source.
        /// </summary>
        /// <param name="index"></param>
        void RefereshPanel(int index)
        {
            if (index == 0)
                swithchParent(_pendingList, _orderList.Where(x => x.OrderStatus == ESaleOrderStatus.Pending || x.OrderStatus == ESaleOrderStatus.Rejected));
            else if (index == 1)
                swithchParent(_saleDepartment, _orderList.Where(x => x.OrderStatus == ESaleOrderStatus.SaleDepartmentRejected || x.OrderStatus == ESaleOrderStatus.SaleDepartmentApproved));
            else if (index == 2)
                swithchParent(_accountDepartment, _orderList.Where(x => x.OrderStatus == ESaleOrderStatus.AccountDepartmentApproved || x.OrderStatus == ESaleOrderStatus.AccountDepartmentRejected));
            else if (index == 3)
                swithchParent(_finalDepartment, _orderList.Where(x => x.OrderStatus == ESaleOrderStatus.FinalDepartmentApproved || x.OrderStatus == ESaleOrderStatus.FinalDepartmentRejected));
        }

        /// <summary>
        /// Current selected row data-source object.
        /// </summary>
        OrderListingDto selectedOrder = null;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedOrder = null;
            if (!(e.RowIndex >= 0))
            {
                updateButtonStatus(false, false);
                return;
            }

            var orderListingDto = ((List<OrderListingDto>)dataGridView1.DataSource)[e.RowIndex];
            if (orderListingDto == null) return;
            selectedOrder = orderListingDto;

            updateButtonStatus(orderListingDto);
        }

        private void _btnReject_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                ERPMessage.OK("Please select Order First.");
                return;
            }

            if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.Pending)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.Rejected);

            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.SaleDepartmentApproved)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.SaleDepartmentRejected);

            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.AccountDepartmentApproved)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.AccountDepartmentRejected);

            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.FinalDepartmentApproved)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.FinalDepartmentRejected);
        }

        private void _btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                ERPMessage.OK("Please select Order First.");
                return;
            }

            if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.Pending || selectedOrder.OrderStatus == Model.ESaleOrderStatus.Rejected)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.SaleDepartmentApproved);

            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.SaleDepartmentApproved)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.AccountDepartmentApproved);
            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.SaleDepartmentRejected)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.SaleDepartmentApproved);
    
            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.AccountDepartmentApproved)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.FinalDepartmentApproved);
            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.AccountDepartmentRejected)
                updateOrderStatus(selectedOrder.Id, ESaleOrderStatus.AccountDepartmentApproved);

            else if (selectedOrder.OrderStatus == Model.ESaleOrderStatus.FinalDepartmentApproved)
            {
                ERPMessage.OK("Already Final Approved.", "Already Done", MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Update data in database.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="orderStatus"></param>
        void updateOrderStatus(int orderId, ESaleOrderStatus orderStatus)
        {
            var query = "update [Order].[Orders] Set OrderStatus=@OrderStatus Where Id = @Id";
            var dp = new DynamicParameters(query);
            dp.Add("OrderStatus", orderStatus);
            dp.Add("Id", orderId);

            try
            {
                ERPSqlHelper.ExcuteFirstOrDefault<dynamic>(query, dp);
                ERPMessage.OK("Success", "UpateError");
                selectedOrder.OrderStatus = orderStatus;
                updateButtonStatus(selectedOrder);
                RefereshPanel(tabControl1.SelectedIndex);
            }
            catch (Exception ex)
            {
                ERPMessage.OK(ex.Message, "UpateError", MessageBoxIcon.Error);
            }
        }
    }
}
