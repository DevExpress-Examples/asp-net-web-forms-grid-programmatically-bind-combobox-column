<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="BindToList._Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" OnCellEditorInitialize="ASPxGridView1_CellEditorInitialize" OnRowUpdating="ASPxGridView1_RowUpdating">
            <Columns>
                <dxwgv:GridViewCommandColumn VisibleIndex="0" ShowEditButton="true">
                </dxwgv:GridViewCommandColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Id" VisibleIndex="1">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Name" VisibleIndex="2">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataComboBoxColumn FieldName="Status" VisibleIndex="3">
                    <PropertiesComboBox TextField="Name" ValueField="Id" ValueType="System.Int32">
                    </PropertiesComboBox>
                </dxwgv:GridViewDataComboBoxColumn>
            </Columns>
        </dxwgv:ASPxGridView>
    </div>
    </form>
</body>
</html>
