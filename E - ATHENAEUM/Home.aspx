<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="E___ATHENAEUM.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto+Slab&display=swap" rel="stylesheet">

    <style>

        body {
            margin: 0;
            font-family: "Source Sans Pro", sans-serif;
            min-height: 100vh;
            display: grid;
            background: #1a1c1d;
            color: #ffffff;
            font-family: 'Roboto Slab', serif;
        }

        h2 {
            font-size: 3.1vw;
            font-weight: normal;
        }

        h3 {
            font-size: 2.1vw;
            color: #22bb45;
        }
        .ptag{
            font-size: 1.8vw;
            color: #22bb45;
        }

        .skill-1-ptag {
            font-size: 1.8vw;
        }

        .skill-row {
            margin: 40px auto;
            width: 70%;
            text-align: left;
            line-height: 2;
        }

        .skill-row-1 {
            margin: 40px auto;
            width: 60%;
            text-align: right;
            line-height: 2;
        }

        .img {
            width: 150px;
            float: left;
            margin-right: 30px;
        }

        .img-1 {
            width: 150px;
            float: right;
            margin-left: 30px;
        }

        hr {
            border-top: 2px dashed;
            color: #f53e31;
            width: 50%;
            margin-top: 0;
            margin-bottom: 2px;
        }

        .animate-charcter {
            text-transform: uppercase;
            display: inline-block;
            font-size: 5.3vw;
        }
    </style>

    <br />
    <br />
    <br />
    <center>
        <h1 class="animate-charcter">WELCOME TO E - ATHENAEUM</h1>
    </center>
    <br />
    <center><p class="ptag">A DYNAMIC WEB APPLICATION FOR LIBRARY MANAGEMENT USING ASP.NET</p></center>
    <br />
    <br />

    <hr />
    <hr />
    <br />
    <center>
        <div>
            <h2>Member - Features</h2>
            <div class="skill-row">
                <img class="img" src="images/agreement.png" alt="">
                <h3>Login & Sign-Up</h3>
                <p class="skill-1-ptag">New members can sign-up anytime freely and can log in to their accounts using their credentials.</p>
            </div>
            <br />
            <div class="skill-row-1">
                <img class="img-1" src="images/book.png" alt="">
                <h3>View Books</h3>
                <p class="skill-1-ptag">Members can see the books available in the library, with rich data like the book's genre, description, current stock, and much more.</p>
            </div>
            <br />
            <div class="skill-row">
                <img class="img" src="images/ui.png" alt="">
                <h3>View Profile</h3>
                <p class="skill-1-ptag">Existing members, once logged in can view and edit various profile fields such as their address, pin code, password, etc., </p>
            </div>
        </div>
    </center>
    <br />
    <br />

    <hr />
    <br />
    <center>
        <div>
            <h2>Admin - Features</h2>
            <div class="skill-row">
                <img class="img" src="images/people.png" alt="">
                <h3>Member Management</h3>
                <p class="skill-1-ptag">Admin can easily view the current members of the library, alter their profile status, or even delete a member in extreme cases.</p>
            </div>
            <br />
            <div class="skill-row-1">
                <img class="img-1" src="images/writer-soft.png" alt="">
                <h3>Author Management</h3>
                <p class="skill-1-ptag">Admin can easily add, update, delete author's data to the library management system based on their needs.</p>
            </div>
            <br />
            <div class="skill-row">
                <img class="img" src="images/publisher-soft.png" alt="">
                <h3>Publisher Management</h3>
                <p class="skill-1-ptag">Admin can easily add, update, delete publisher's data to the library management system based on their needs. </p>
            </div>
            <br />
            <div class="skill-row-1">
                <img class="img-1" src="images/inventory.png" alt="">
                <h3>Book Inventory</h3>
                <p class="skill-1-ptag">Admin can view the members who have received books, also can easily add, update, delete the available books in the inventory with rich data such as available stock, book description, book ID, etc.,</p>
            </div>
            <br />
            <div class="skill-row">
                <img class="img" src="images/giving.png" alt="">
                <h3>Book Issue</h3>
                <p class="skill-1-ptag">Admin can either return or issue books to the members, while also being able to view the members who already received books, and members on defaulters list.</p>
            </div>
        </div>
    </center>
    <br />
    <br />

</asp:Content>
