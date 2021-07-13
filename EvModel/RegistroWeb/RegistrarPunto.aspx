<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarPunto.aspx.cs" Inherits="RegistroWeb.RegistrarPunto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Menu" runat="server">
    
    <div>
        <asp:Label ID="mensajeLb1" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-warning text-black text-center">
                    <h5>Registrar Punto de Carga</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="IdeTxt">Identificador</label>
                        <asp:TextBox runat="server" Type="number" ID="IdeTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ErrorMessage="Ingrese un Identificador" CssClass="text-danger"
                            ControlToValidate="IdeTxt">
                        </asp:RequiredFieldValidator>
                    </div>  
                    <div class="mb-3">
                        <label class="form-label" for="CapMaxTxt">Capacidad Maxima</label>
                        <asp:TextBox runat="server" Type="number" ID="CapMaxTxt" CssClass="form-control" MaxLength="1" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ErrorMessage="No exeda la capacidad maxima" CssClass="text-danger"
                            ControlToValidate="CapMaxTxt">
                        </asp:RequiredFieldValidator>
                    </div>  
                    <div class="mb-3">
                        <label class="form-label" for="TipoRdl">Tipos</label>
                        <asp:RadioButtonList runat="server" ID="TipoRdl" CssClass="form-control">
                            <asp:ListItem Value="1" Text="Dual" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Electrico"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                     <div class="mb-3">
                        <label class="form-label" for="VidaTxt">Vida Util</label> 
                        <asp:TextBox runat="server" ID="VidaTxt" CssClass="form-control"></asp:TextBox>  
                         <asp:Calendar ID = "Calendar1" runat = "server" SelectionMode="DayWeekMonth" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ErrorMessage="Seleccione una fecha" CssClass="text-danger"
                            ControlToValidate="VidaTxt">
                        </asp:RequiredFieldValidator>
                        
                    </div> 
                    </div>
                 <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="RegistrarBtn" CssClass="btn btn-dark" Text="Registrar Punto de Carga"
                        OnClick="RegistrarBtn_Click"/>
                </div>
                </div>
               
            </div>
        </div>


</asp:Content>
