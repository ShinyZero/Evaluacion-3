<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarEstacion.aspx.cs" Inherits="RegistroWeb.RegistrarEstacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Menu" runat="server">
     <style type="text/css">
        #Menu_TipoRDL label{
            margin-left: 10px;
        }
    </style>
    <div>
        <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

        <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-warning text-white text-center">
                    <h5>Registrar Estacion</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="IdTxt">ID de la Estación</label>
                        <asp:TextBox runat="server" type="number" ID="IdTxt" CssClass="form-control"></asp:TextBox>
                         <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" CssClass="text-danger"
                           ControlToValidate="IdTxt" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="true" ></asp:CustomValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="DireccionTxt">Direccion</label>
                        <asp:TextBox runat="server" ID="DireccionTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFileValidator3" runat="server" ErrorMessage="Debe ingresar una direccion"
                            CssClass="text-danger" ControlToValidate="DireccionTxt" >
                        </asp:RequiredFieldValidator>                         
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="estacionDBL">Region</label>
                        <asp:DropDownList runat="server" ID="estacionDBL" CssClass="form-select"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="CapCargaTxt">Capacidad de Carga</label>
                        <asp:TextBox runat="server" Type="number" ID="CapCargaTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ErrorMessage="Exede la Capacidad de Carga" CssClass="text-danger"
                            ControlToValidate="CapCargaTxt">
                        </asp:RequiredFieldValidator>
                    </div>
                   <div class="mb-3">
                        <label class="form-label" for="horarioAperturaTxt">Horario de Apertura</label>
                        <asp:TextBox runat="server" ID="horarioAperturaTxt" CssClass="form-control"></asp:TextBox>
                         <asp:CustomValidator ID="HorarioCV" runat="server" ErrorMessage="CustomValidator"
                            CssClass="text-danger" ControlToValidate="horarioAperturaTxt" OnServerValidate="HorarioCV_ServerValidate"
                            ValidateEmptyText="true"
                            ></asp:CustomValidator>
                        
                    </div>
                      <div ">
                         <label class="form-label" for="horarioCierreTxt">Horario de Ciere</label>
                        <asp:TextBox runat="server" ID="horarioCierreTxt" CssClass="form-control" ></asp:TextBox>
                         <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"
                            CssClass="text-danger" ControlToValidate="horarioCierreTxt" OnServerValidate="HorarioCV_ServerValidate"
                            ValidateEmptyText="true"
                            ></asp:CustomValidator>
                    </div>

                </div>
                <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="RegistrarBtn" CssClass="btn btn-dark" Text="Crear Estacion"
                        OnClick="RegistrarBtn_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
