<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerPunto.aspx.cs" Inherits="RegistroWeb.VerPunto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Menu" runat="server">
     <div>
        <asp:Label ID="mensajeLb1" CssClass="text-success h1" runat="server"></asp:Label>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando...</span>
                </ProgressTemplate>

            </asp:UpdateProgress>

            <!-- filtro -->

              <div class="card-body">
                            <asp:DropDownList ID="TipoRdl" runat="server" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="TipoRdl_SelectedIndexChanged">
                                <asp:ListItem Value="Dual" Selected="True" Text="Dual"></asp:ListItem>
                                <asp:ListItem Value="Electrico" Text="Electrico"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:CheckBox ID="todosChx" Checked="true" runat="server"
                                AutoPostBack="true" OnCheckedChanged="todosChx_CheckedChanged" Text="Ver Todos" />
                            <!--Creacion de grillas -->
                            <div class="mt-5">
                                <asp:GridView ID="PuntoCargaGrid" runat="server"
                                    AutoGenerateColumns="false" CssClass="table table-hover" EmptyDataText="No hay estaciones registradas" OnSelectedIndexChanged="PuntoCargaGrid_SelectedIndexChanged">
                                    <Columns>
                                        <asp:BoundField HeaderText="Identificador" DataField="Identificador" />
                                        <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapMax" />
                                        <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                                        <asp:BoundField HeaderText="Vida Util" DataField="VidaUtil" />
                                        <asp:CommandField HeaderText="Seleccionar" SelectText="Actualizar" ControlStyle-CssClass="btn btn-info text-black" ShowSelectButton="True" />
                                    </Columns>
                                </asp:GridView>
                            </div>



                   <div>
        <asp:Label ID="Label1" CssClass="text-success h1" runat="server"></asp:Label>
    </div>
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-secondary text-black text-center">
                    <h5>Actualizar Punto de Carga</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="IdentificadorTxt">Identificador</label>
                        <asp:TextBox ReadOnly="true" runat="server" ID="IdentificadorTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ErrorMessage="Primero seleccione el Punto de carga que quiere actualizar " CssClass="text-danger"
                            ControlToValidate="IdentificadorTxt">
                        </asp:RequiredFieldValidator>
                    </div>  
                    <div class="mb-3">
                        <label class="form-label" for="capaTxt">Capacidad Maxima</label>
                        <asp:TextBox runat="server" Type="number" ID="capaTxt" CssClass="form-control" MaxLength="1" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ErrorMessage="No exeda la capacidad maxima" CssClass="text-danger"
                            ControlToValidate="capaTxt">
                        </asp:RequiredFieldValidator>
                    </div>  
                    <div class="mb-3">
                        <label class="form-label" for="TiposRd">Tipos</label>
                        <asp:RadioButtonList runat="server" ID="TiposRd" CssClass="form-control">
                            <asp:ListItem Value="Dual" Text="Dual" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="Electrico" Text="Electrico"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                     <div class="mb-3">
                        <label class="form-label" for="Vidatxt">Vida Util</label> 
                        <asp:TextBox ReadOnly="true" runat="server" ID="Vidatxt" CssClass="form-control"></asp:TextBox>  
                         <asp:Calendar ID = "Calendar1" runat = "server" SelectionMode="DayWeekMonth" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ErrorMessage="Seleccione una fecha" CssClass="text-danger"
                            ControlToValidate="VidaTxt">
                        </asp:RequiredFieldValidator>
                        
                    </div> 
                    </div>
                     <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="Actualizar" CssClass="btn btn-dark" Text="Registrar Punto de Carga"
                       OnClick="ActualizarBtn_Click"
                        />

                </div>
                </div>
               
            </div>
        </div>

        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
