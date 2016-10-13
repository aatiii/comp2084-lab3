<%@ Page Title="Student Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student-details.aspx.cs" Inherits="week6.student_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Details</h1>
    <div class="form-group">
        <label for="LastName" class="col-sm-3 control-label">Last Name: </label>
        <asp:TextBox ID="LastName" runat="server" required/>
    </div>
    <div class="form-group">
        <label for="FirstMidName" class="col-sm-3 control-label">First Name: </label>
        <asp:TextBox ID="FirstMidName" runat="server" required/>
    </div>
    <div class="form-group">
        <label for="EnrollmentDate" class="col-sm-3 control-label">Enrollment Date: </label>
        <asp:TextBox ID="EnrollmentDate" runat="server" type="datetime-local" required />
    </div>
    <asp:button class="btn btn-success col-sm-offset-3" id="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
</asp:Content>
