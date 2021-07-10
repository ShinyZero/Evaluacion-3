<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerEstacion.aspx.cs" Inherits="RegistroWeb.VerEstacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Menu" runat="server">
    <div class="mt-5">
        <asp:GridView ID="estacionesGrid" runat="server"
            AutoGenerateColumns="false" CssClass="table table-hover" OnRowCommand="estacionesGrid_RowCommand"
            EmptyDataText="No hay estaciones registradas">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="Id" />
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Region" DataField="Region"/>
                <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapCarga"/>
                <asp:BoundField HeaderText="Horario" DataField="Horario"/>
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Eliminar Estacion"
                            CssClass="btn btn-danger" CommandName="Eliminar"
                            CommandArgument='<%# Eval("Id")%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
