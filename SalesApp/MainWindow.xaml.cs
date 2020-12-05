using System.Windows;
using Services.ServiceProduct;

namespace SalesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductServices productServices;
        public MainWindow()
        {
            InitializeComponent();

            productServices = new ProductServices();

            Loaded += MainWindow_Loaded;

            ButtonAdd.Click += ButtonAdd_Click;
            ButtonList.Click += ButtonList_Click;
            ButtonSearch.Click += ButtonSearch_Click;


        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //var product = productServices.Search(TextBoxProductID.Text);

                //if (product != null)
                //{
                //    TextBoxProductName.Text = product.ProductName;
                //    TextBoxProductCost.Text = product.ProductCost.ToString();
                //    TextBoxProductPrice.Text = product.ProductPrice.ToString();
                //}

                if (TextBoxProductName.Text == string.Empty)
                {
                    throw new System.Exception("TextBox is empty");
                }


                var products = productServices.SearchByProductName(TextBoxProductName.Text);

                if (products.Count == 0) 
                {
                    dataGridProduct.ItemsSource = products;
                    throw new System.Exception("No Such product found!"); 
                }
                else
                {
                    dataGridProduct.ItemsSource = products;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonList_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridProduct.ItemsSource = productServices.List();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                productServices.Add(TextBoxProductID.Text, TextBoxProductName.Text.ToUpper(), decimal.Parse(TextBoxProductCost.Text), decimal.Parse(TextBoxProductPrice.Text));
                dataGridProduct.ItemsSource = productServices.List();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBoxProductID.Focus();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
