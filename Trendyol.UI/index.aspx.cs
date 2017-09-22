using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trendyol.Business.Abstruct.AbstructDTO;
using Trendyol.Business.Concrete;
using Trendyol.Business.Concrete.ConcreteDTO;
using Trendyol.Model.DTO;
using Trendyol.Model.Entities;

namespace Trendyol.UI
{
    public partial class index : System.Web.UI.Page
    {
        EFProductManagementBLL _productManagementBLL = new EFProductManagementBLL();
        EFOrderManagementBLL _orderManagementBLL = new EFOrderManagementBLL();
        EFOrderProductManagementDTO _orderProductManagementDTO = new EFOrderProductManagementDTO();
        static List<OrderProductDTO> orderProductDTO = new List<OrderProductDTO>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateProduct();
                FillProducts();
            }
            FillOrders();
        }

        protected void btnOrderAdd_Click(object sender, EventArgs e)
        {
            List<Orders> orders = new List<Orders>();
            foreach (var item in orderProductDTO)
            {
            Orders order = new Orders();
            order.OrderID = item.OrderID;
            order.ProductID = item.ProductID;
            order.Store = item.Store;
            order.Operating = item.Operating;
            order.EndOrder = item.EndOrder;
            orders.Add(order);
            _orderManagementBLL.Add(order);
            }
            FillOrders();
            
        }
        protected void ProductAdd(object sender, EventArgs e)
        {
            Label1.Text = "";
            string productID = grdProducts.SelectedDataKey.Value.ToString();
            Products product;
            product = _productManagementBLL.GetByProductID(new Guid(productID));
            Orders order = new Orders();
            order.OrderID = Guid.NewGuid();
            order.ProductID = product.ProductID;
            order.Quantity = 1;
            OrderProductDTO orderProduct = new OrderProductDTO();
            orderProduct.OrderID = order.OrderID;
            orderProduct.ProductID = product.ProductID;
            orderProduct.Quantity = 1;
            orderProduct.UnitPrice = product.UnitPrice * orderProduct.Quantity;
            orderProduct.Store = order.Store;
            orderProduct.ProductName = product.ProductName;

            if (!orderProductDTO.Exists(x => x.ProductName == product.ProductName))
                orderProductDTO.Add(orderProduct);
            else
            {
                Label1.Text = "Bu ürün daha önce eklenmiştir!";
                orderProductDTO.First(x => x.ProductName == product.ProductName).Quantity = orderProduct.Quantity + 1;
            }
            FillOrderDetails();
        }
        void FillProducts()
        {
            grdProducts.DataSource = _productManagementBLL.GetAll();
            grdProducts.DataBind();
        }
        void FillOrderDetails()
        {
            grdOrderProducts.DataSource = orderProductDTO;
            grdOrderProducts.DataBind();
        }
        void FillOrders()
        {
            grdOrders.DataSource = orderProductDTO;
            grdOrders.DataBind();
        }

        protected void grdOrderProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //orderProductDTO.RemoveAt(grdOrderProducts.se);
            //FillOrderDetails();
        }

        protected void btnProductsAdd_Click(object sender, EventArgs e)
        {
            CreateProduct();
            FillProducts();
        }

        void CreateProduct()
        {
            for (int i = 0; i < 10; i++)
            {
            Products product = new Products();
            product.ProductID = Guid.NewGuid();
            product.ProductName = "Ürün" + i;
            product.UnitPrice = 15;
            product.UnitsInStock = 15;
            _productManagementBLL.Add(product);
            }
        }

    }
}