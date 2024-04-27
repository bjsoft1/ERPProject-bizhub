using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERPProject.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Addinguserbulkseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Person",
                table: "Customers",
                columns: new[] { "Id", "CreationTime", "CreatorUserId", "CustomerAddress", "CustomerEmail", "CustomerMobile", "CustomerName", "LastModifiedTime", "LastModifiedUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-1, Lalitpur", "bijay.adhikari.27649@gmail.com", "9800000001", "Bijay Adhikari-1", null, null },
                    { 2, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-2, Lalitpur", "bijay.adhikari.27650@gmail.com", "9800000002", "Bijay Adhikari-2", null, null },
                    { 3, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-3, Lalitpur", "bijay.adhikari.27651@gmail.com", "9800000003", "Bijay Adhikari-3", null, null },
                    { 4, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-4, Lalitpur", "bijay.adhikari.27652@gmail.com", "9800000004", "Bijay Adhikari-4", null, null },
                    { 5, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-5, Lalitpur", "bijay.adhikari.27653@gmail.com", "9800000005", "Bijay Adhikari-5", null, null },
                    { 6, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-6, Lalitpur", "bijay.adhikari.27654@gmail.com", "9800000006", "Bijay Adhikari-6", null, null },
                    { 7, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-7, Lalitpur", "bijay.adhikari.27655@gmail.com", "9800000007", "Bijay Adhikari-7", null, null },
                    { 8, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-8, Lalitpur", "bijay.adhikari.27656@gmail.com", "9800000008", "Bijay Adhikari-8", null, null },
                    { 9, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-9, Lalitpur", "bijay.adhikari.27657@gmail.com", "9800000009", "Bijay Adhikari-9", null, null },
                    { 10, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-10, Lalitpur", "bijay.adhikari.27658@gmail.com", "9800000010", "Bijay Adhikari-10", null, null },
                    { 11, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-11, Lalitpur", "bijay.adhikari.27659@gmail.com", "9800000011", "Bijay Adhikari-11", null, null },
                    { 12, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-12, Lalitpur", "bijay.adhikari.27660@gmail.com", "9800000012", "Bijay Adhikari-12", null, null },
                    { 13, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-13, Lalitpur", "bijay.adhikari.27661@gmail.com", "9800000013", "Bijay Adhikari-13", null, null },
                    { 14, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-14, Lalitpur", "bijay.adhikari.27662@gmail.com", "9800000014", "Bijay Adhikari-14", null, null },
                    { 15, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-15, Lalitpur", "bijay.adhikari.27663@gmail.com", "9800000015", "Bijay Adhikari-15", null, null },
                    { 16, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-16, Lalitpur", "bijay.adhikari.27664@gmail.com", "9800000016", "Bijay Adhikari-16", null, null },
                    { 17, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-17, Lalitpur", "bijay.adhikari.27665@gmail.com", "9800000017", "Bijay Adhikari-17", null, null },
                    { 18, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-18, Lalitpur", "bijay.adhikari.27666@gmail.com", "9800000018", "Bijay Adhikari-18", null, null },
                    { 19, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-19, Lalitpur", "bijay.adhikari.27667@gmail.com", "9800000019", "Bijay Adhikari-19", null, null },
                    { 20, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-20, Lalitpur", "bijay.adhikari.27668@gmail.com", "9800000020", "Bijay Adhikari-20", null, null },
                    { 21, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-21, Lalitpur", "bijay.adhikari.27669@gmail.com", "9800000021", "Bijay Adhikari-21", null, null },
                    { 22, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-22, Lalitpur", "bijay.adhikari.27670@gmail.com", "9800000022", "Bijay Adhikari-22", null, null },
                    { 23, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-23, Lalitpur", "bijay.adhikari.27671@gmail.com", "9800000023", "Bijay Adhikari-23", null, null },
                    { 24, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-24, Lalitpur", "bijay.adhikari.27672@gmail.com", "9800000024", "Bijay Adhikari-24", null, null },
                    { 25, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-25, Lalitpur", "bijay.adhikari.27673@gmail.com", "9800000025", "Bijay Adhikari-25", null, null },
                    { 26, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-26, Lalitpur", "bijay.adhikari.27674@gmail.com", "9800000026", "Bijay Adhikari-26", null, null },
                    { 27, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-27, Lalitpur", "bijay.adhikari.27675@gmail.com", "9800000027", "Bijay Adhikari-27", null, null },
                    { 28, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-28, Lalitpur", "bijay.adhikari.27676@gmail.com", "9800000028", "Bijay Adhikari-28", null, null },
                    { 29, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-29, Lalitpur", "bijay.adhikari.27677@gmail.com", "9800000029", "Bijay Adhikari-29", null, null },
                    { 30, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-30, Lalitpur", "bijay.adhikari.27678@gmail.com", "9800000030", "Bijay Adhikari-30", null, null },
                    { 31, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-31, Lalitpur", "bijay.adhikari.27679@gmail.com", "9800000031", "Bijay Adhikari-31", null, null },
                    { 32, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-32, Lalitpur", "bijay.adhikari.27680@gmail.com", "9800000032", "Bijay Adhikari-32", null, null },
                    { 33, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-33, Lalitpur", "bijay.adhikari.27681@gmail.com", "9800000033", "Bijay Adhikari-33", null, null },
                    { 34, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-34, Lalitpur", "bijay.adhikari.27682@gmail.com", "9800000034", "Bijay Adhikari-34", null, null },
                    { 35, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-35, Lalitpur", "bijay.adhikari.27683@gmail.com", "9800000035", "Bijay Adhikari-35", null, null },
                    { 36, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-36, Lalitpur", "bijay.adhikari.27684@gmail.com", "9800000036", "Bijay Adhikari-36", null, null },
                    { 37, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-37, Lalitpur", "bijay.adhikari.27685@gmail.com", "9800000037", "Bijay Adhikari-37", null, null },
                    { 38, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-38, Lalitpur", "bijay.adhikari.27686@gmail.com", "9800000038", "Bijay Adhikari-38", null, null },
                    { 39, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-39, Lalitpur", "bijay.adhikari.27687@gmail.com", "9800000039", "Bijay Adhikari-39", null, null },
                    { 40, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-40, Lalitpur", "bijay.adhikari.27688@gmail.com", "9800000040", "Bijay Adhikari-40", null, null },
                    { 41, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-41, Lalitpur", "bijay.adhikari.27689@gmail.com", "9800000041", "Bijay Adhikari-41", null, null },
                    { 42, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-42, Lalitpur", "bijay.adhikari.27690@gmail.com", "9800000042", "Bijay Adhikari-42", null, null },
                    { 43, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-43, Lalitpur", "bijay.adhikari.27691@gmail.com", "9800000043", "Bijay Adhikari-43", null, null },
                    { 44, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-44, Lalitpur", "bijay.adhikari.27692@gmail.com", "9800000044", "Bijay Adhikari-44", null, null },
                    { 45, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-45, Lalitpur", "bijay.adhikari.27693@gmail.com", "9800000045", "Bijay Adhikari-45", null, null },
                    { 46, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-46, Lalitpur", "bijay.adhikari.27694@gmail.com", "9800000046", "Bijay Adhikari-46", null, null },
                    { 47, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-47, Lalitpur", "bijay.adhikari.27695@gmail.com", "9800000047", "Bijay Adhikari-47", null, null },
                    { 48, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-48, Lalitpur", "bijay.adhikari.27696@gmail.com", "9800000048", "Bijay Adhikari-48", null, null },
                    { 49, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-49, Lalitpur", "bijay.adhikari.27697@gmail.com", "9800000049", "Bijay Adhikari-49", null, null },
                    { 50, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-50, Lalitpur", "bijay.adhikari.27698@gmail.com", "9800000050", "Bijay Adhikari-50", null, null },
                    { 51, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-51, Lalitpur", "bijay.adhikari.27699@gmail.com", "9800000051", "Bijay Adhikari-51", null, null },
                    { 52, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-52, Lalitpur", "bijay.adhikari.27700@gmail.com", "9800000052", "Bijay Adhikari-52", null, null },
                    { 53, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-53, Lalitpur", "bijay.adhikari.27701@gmail.com", "9800000053", "Bijay Adhikari-53", null, null },
                    { 54, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-54, Lalitpur", "bijay.adhikari.27702@gmail.com", "9800000054", "Bijay Adhikari-54", null, null },
                    { 55, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-55, Lalitpur", "bijay.adhikari.27703@gmail.com", "9800000055", "Bijay Adhikari-55", null, null },
                    { 56, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-56, Lalitpur", "bijay.adhikari.27704@gmail.com", "9800000056", "Bijay Adhikari-56", null, null },
                    { 57, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-57, Lalitpur", "bijay.adhikari.27705@gmail.com", "9800000057", "Bijay Adhikari-57", null, null },
                    { 58, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-58, Lalitpur", "bijay.adhikari.27706@gmail.com", "9800000058", "Bijay Adhikari-58", null, null },
                    { 59, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-59, Lalitpur", "bijay.adhikari.27707@gmail.com", "9800000059", "Bijay Adhikari-59", null, null },
                    { 60, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-60, Lalitpur", "bijay.adhikari.27708@gmail.com", "9800000060", "Bijay Adhikari-60", null, null },
                    { 61, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-61, Lalitpur", "bijay.adhikari.27709@gmail.com", "9800000061", "Bijay Adhikari-61", null, null },
                    { 62, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-62, Lalitpur", "bijay.adhikari.27710@gmail.com", "9800000062", "Bijay Adhikari-62", null, null },
                    { 63, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-63, Lalitpur", "bijay.adhikari.27711@gmail.com", "9800000063", "Bijay Adhikari-63", null, null },
                    { 64, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-64, Lalitpur", "bijay.adhikari.27712@gmail.com", "9800000064", "Bijay Adhikari-64", null, null },
                    { 65, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-65, Lalitpur", "bijay.adhikari.27713@gmail.com", "9800000065", "Bijay Adhikari-65", null, null },
                    { 66, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-66, Lalitpur", "bijay.adhikari.27714@gmail.com", "9800000066", "Bijay Adhikari-66", null, null },
                    { 67, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-67, Lalitpur", "bijay.adhikari.27715@gmail.com", "9800000067", "Bijay Adhikari-67", null, null },
                    { 68, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-68, Lalitpur", "bijay.adhikari.27716@gmail.com", "9800000068", "Bijay Adhikari-68", null, null },
                    { 69, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-69, Lalitpur", "bijay.adhikari.27717@gmail.com", "9800000069", "Bijay Adhikari-69", null, null },
                    { 70, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-70, Lalitpur", "bijay.adhikari.27718@gmail.com", "9800000070", "Bijay Adhikari-70", null, null },
                    { 71, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-71, Lalitpur", "bijay.adhikari.27719@gmail.com", "9800000071", "Bijay Adhikari-71", null, null },
                    { 72, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-72, Lalitpur", "bijay.adhikari.27720@gmail.com", "9800000072", "Bijay Adhikari-72", null, null },
                    { 73, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-73, Lalitpur", "bijay.adhikari.27721@gmail.com", "9800000073", "Bijay Adhikari-73", null, null },
                    { 74, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-74, Lalitpur", "bijay.adhikari.27722@gmail.com", "9800000074", "Bijay Adhikari-74", null, null },
                    { 75, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-75, Lalitpur", "bijay.adhikari.27723@gmail.com", "9800000075", "Bijay Adhikari-75", null, null },
                    { 76, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-76, Lalitpur", "bijay.adhikari.27724@gmail.com", "9800000076", "Bijay Adhikari-76", null, null },
                    { 77, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-77, Lalitpur", "bijay.adhikari.27725@gmail.com", "9800000077", "Bijay Adhikari-77", null, null },
                    { 78, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-78, Lalitpur", "bijay.adhikari.27726@gmail.com", "9800000078", "Bijay Adhikari-78", null, null },
                    { 79, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-79, Lalitpur", "bijay.adhikari.27727@gmail.com", "9800000079", "Bijay Adhikari-79", null, null },
                    { 80, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-80, Lalitpur", "bijay.adhikari.27728@gmail.com", "9800000080", "Bijay Adhikari-80", null, null },
                    { 81, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-81, Lalitpur", "bijay.adhikari.27729@gmail.com", "9800000081", "Bijay Adhikari-81", null, null },
                    { 82, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-82, Lalitpur", "bijay.adhikari.27730@gmail.com", "9800000082", "Bijay Adhikari-82", null, null },
                    { 83, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-83, Lalitpur", "bijay.adhikari.27731@gmail.com", "9800000083", "Bijay Adhikari-83", null, null },
                    { 84, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-84, Lalitpur", "bijay.adhikari.27732@gmail.com", "9800000084", "Bijay Adhikari-84", null, null },
                    { 85, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-85, Lalitpur", "bijay.adhikari.27733@gmail.com", "9800000085", "Bijay Adhikari-85", null, null },
                    { 86, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-86, Lalitpur", "bijay.adhikari.27734@gmail.com", "9800000086", "Bijay Adhikari-86", null, null },
                    { 87, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-87, Lalitpur", "bijay.adhikari.27735@gmail.com", "9800000087", "Bijay Adhikari-87", null, null },
                    { 88, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-88, Lalitpur", "bijay.adhikari.27736@gmail.com", "9800000088", "Bijay Adhikari-88", null, null },
                    { 89, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-89, Lalitpur", "bijay.adhikari.27737@gmail.com", "9800000089", "Bijay Adhikari-89", null, null },
                    { 90, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-90, Lalitpur", "bijay.adhikari.27738@gmail.com", "9800000090", "Bijay Adhikari-90", null, null },
                    { 91, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-91, Lalitpur", "bijay.adhikari.27739@gmail.com", "9800000091", "Bijay Adhikari-91", null, null },
                    { 92, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-92, Lalitpur", "bijay.adhikari.27740@gmail.com", "9800000092", "Bijay Adhikari-92", null, null },
                    { 93, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-93, Lalitpur", "bijay.adhikari.27741@gmail.com", "9800000093", "Bijay Adhikari-93", null, null },
                    { 94, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-94, Lalitpur", "bijay.adhikari.27742@gmail.com", "9800000094", "Bijay Adhikari-94", null, null },
                    { 95, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-95, Lalitpur", "bijay.adhikari.27743@gmail.com", "9800000095", "Bijay Adhikari-95", null, null },
                    { 96, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-96, Lalitpur", "bijay.adhikari.27744@gmail.com", "9800000096", "Bijay Adhikari-96", null, null },
                    { 97, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-97, Lalitpur", "bijay.adhikari.27745@gmail.com", "9800000097", "Bijay Adhikari-97", null, null },
                    { 98, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-98, Lalitpur", "bijay.adhikari.27746@gmail.com", "9800000098", "Bijay Adhikari-98", null, null },
                    { 99, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-99, Lalitpur", "bijay.adhikari.27747@gmail.com", "9800000099", "Bijay Adhikari-99", null, null },
                    { 100, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-100, Lalitpur", "bijay.adhikari.27748@gmail.com", "9800000100", "Bijay Adhikari-100", null, null },
                    { 101, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, "Thaiba-101, Lalitpur", "bijay.adhikari.27749@gmail.com", "9800000101", "Bijay Adhikari-101", null, null }
                });

            migrationBuilder.InsertData(
                schema: "Store",
                table: "Products",
                columns: new[] { "Id", "CreationTime", "CreatorUserId", "LastModifiedTime", "LastModifiedUserId", "ProductDescription", "ProductName", "ProductPurchasePrice", "ProductSellingPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-1", 900f, 1000f },
                    { 2, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-2", 901f, 1001f },
                    { 3, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-3", 902f, 1002f },
                    { 4, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-4", 903f, 1003f },
                    { 5, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-5", 904f, 1004f },
                    { 6, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-6", 905f, 1005f },
                    { 7, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-7", 906f, 1006f },
                    { 8, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-8", 907f, 1007f },
                    { 9, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-9", 908f, 1008f },
                    { 10, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-10", 909f, 1009f },
                    { 11, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-11", 910f, 1010f },
                    { 12, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-12", 911f, 1011f },
                    { 13, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-13", 912f, 1012f },
                    { 14, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-14", 913f, 1013f },
                    { 15, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-15", 914f, 1014f },
                    { 16, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-16", 915f, 1015f },
                    { 17, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-17", 916f, 1016f },
                    { 18, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-18", 917f, 1017f },
                    { 19, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-19", 918f, 1018f },
                    { 20, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-20", 919f, 1019f },
                    { 21, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-21", 920f, 1020f },
                    { 22, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-22", 921f, 1021f },
                    { 23, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-23", 922f, 1022f },
                    { 24, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-24", 923f, 1023f },
                    { 25, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-25", 924f, 1024f },
                    { 26, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-26", 925f, 1025f },
                    { 27, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-27", 926f, 1026f },
                    { 28, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-28", 927f, 1027f },
                    { 29, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-29", 928f, 1028f },
                    { 30, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-30", 929f, 1029f },
                    { 31, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-31", 930f, 1030f },
                    { 32, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-32", 931f, 1031f },
                    { 33, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-33", 932f, 1032f },
                    { 34, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-34", 933f, 1033f },
                    { 35, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-35", 934f, 1034f },
                    { 36, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-36", 935f, 1035f },
                    { 37, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-37", 936f, 1036f },
                    { 38, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-38", 937f, 1037f },
                    { 39, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-39", 938f, 1038f },
                    { 40, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-40", 939f, 1039f },
                    { 41, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-41", 940f, 1040f },
                    { 42, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-42", 941f, 1041f },
                    { 43, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-43", 942f, 1042f },
                    { 44, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-44", 943f, 1043f },
                    { 45, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-45", 944f, 1044f },
                    { 46, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-46", 945f, 1045f },
                    { 47, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-47", 946f, 1046f },
                    { 48, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-48", 947f, 1047f },
                    { 49, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-49", 948f, 1048f },
                    { 50, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-50", 949f, 1049f },
                    { 51, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), 1, null, null, null, "Mango-51", 950f, 1050f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);
        }
    }
}
