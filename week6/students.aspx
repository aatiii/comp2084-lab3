<%@ Page Title="Student Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="week6.students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Students</h1>
    <a href="student-details.aspx">Add a Student</a>
    <asp:GridView ID="grdStudents" runat="server" CssClass="table table-striped" autogeneratecolumns="false">
        <Columns>
            <asp:BoundField DataField="StudentID" HeaderText="Student ID" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" />
        </Columns>
    </asp:GridView>
</asp:Content>
