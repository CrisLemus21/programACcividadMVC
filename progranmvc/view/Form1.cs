using Negocio;

namespace view
{
    public partial class Form1 : Form
    {
        logica objeto = new logica();
        private string idproductos;
        private bool editar = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void productos()
        {
            logica gg = new logica();
            vista.DataSource = gg.mostrardatos();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            productos();
            
        }
        private void LimpiarForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                
                if (editar == false)
                {
                    try
                    {
                        objeto.InsProd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,idproductos);
                        MessageBox.Show("Registro Insertado exitosamente");
                        productos();
                        LimpiarForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Registro no pude ser agregado");
                    }
                }
               
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                if (vista.SelectedRows.Count > 0)
                {
                    editar = true;
                    textBox1.Text = vista.CurrentRow.Cells["nomProd"].Value.ToString();
                    textBox2.Text = vista.CurrentRow.Cells["descripcion"].Value.ToString();
                    textBox3.Text = vista.CurrentRow.Cells["precio"].Value.ToString();
                    textBox4.Text = vista.CurrentRow.Cells["cantidad"].Value.ToString();
                    textBox5.Text = vista.CurrentRow.Cells["estado"].Value.ToString();
                    idproductos = vista.CurrentRow.Cells["idProducto"].Value.ToString();
                    objeto.ActProd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, idproductos);
                    
                    




                }
                else
                {
                    MessageBox.Show("Favor seleccionar una fila");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vista.SelectedRows.Count > 0)
            {
                idproductos = vista.CurrentRow.Cells["idProducto"].Value.ToString();
                objeto.eliprod(idproductos);
                MessageBox.Show("Se ha Eliminado");
                productos();
            }
            else
            {
                MessageBox.Show("Favor seleccionar una fila");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {
                try
                {
                    objeto.ActProd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, idproductos);
                    MessageBox.Show("Registro se actualizo exitosamente");
                    productos();
                    LimpiarForm();
                    editar = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Registro no pude ser actualizado");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}