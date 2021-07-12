<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerPunto.aspx.cs" Inherits="RegistroWeb.VerPunto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Menu" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando...</span>
                </ProgressTemplate>

            </asp:UpdateProgress>

    <!-- filtro -->
    <asp:DropDownList ID="TipoRdl" runat="server" Enabled="false"
        AutoPostBack="true" OnSelectedIndexChanged="TipoRdl_SelectedIndexChanged">
        <asp:ListItem Value="Dual" Selected="True" Text="Dual"></asp:ListItem>
        <asp:ListItem Value="Electrico" Text="Electrico"></asp:ListItem>
    </asp:DropDownList>

    <asp:CheckBox ID="todosChx" Checked="true" runat="server"
        AutoPostBack="true" OnCheckedChanged="todosChx_CheckedChanged" Text="Ver Todos"/>

    <!--Creacion de grillas -->
    <div class="mt-5">
        <asp:GridView ID="PuntoCargaGrid" runat="server"
            AutoGenerateColumns="false" CssClass="table table-hover" OnRowCommand="PuntoCargaGrid_RowCommand"
            EmptyDataText="">
            <Columns>
                <asp:BoundField HeaderText="Identificador" DataField="Identificador" />
                <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapMax" />
                <asp:BoundField HeaderText="Tipo" DataField="Tipo"/>
                <asp:BoundField HeaderText="Vida Util" DataField="VidaUtil"/>
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Actualizar"
                            CssClass="btn btn-info" CommandName="Actualizar" OnClick="Button1_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
            </ContentTemplate>
        </asp:UpdatePanel>
   

</asp:Content>
