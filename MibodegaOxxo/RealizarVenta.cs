/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 02:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of RealizarVenta.
	/// </summary>
	public partial class RealizarVenta : Form
	{
		public RealizarVenta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			labelNombreUsuario.Text=Program.usuario;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Producto pProducto {get; set;}
		
		void Label1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void inhabilidatCamposDeTexto(){
			txtCodigo1.Enabled=false;
			txtDescripcion1.Enabled=false;
			txtPrecio1.Enabled=false;
			txtCodigo2.Enabled=false;
			txtCodigo3.Enabled=false;
			txtCodigo4.Enabled=false;
			txtCodigo5.Enabled=false;
			txtCodigo6.Enabled=false;
			txtCodigo7.Enabled=false;
			txtCodigo8.Enabled=false;
			txtCodigo9.Enabled=false;
			txtCodigo10.Enabled=false;
			txtDescripcion2.Enabled=false;
			txtDescripcion3.Enabled=false;
			txtDescripcion4.Enabled=false;
			txtDescripcion5.Enabled=false;
			txtDescripcion6.Enabled=false;
			txtDescripcion7.Enabled=false;
			txtDescripcion8.Enabled=false;
			txtDescripcion9.Enabled=false;
			txtDescripcion10.Enabled=false;
			txtPrecio10.Enabled=false;
			txtPrecio1.Enabled=false;
			txtPrecio2.Enabled=false;
			txtPrecio3.Enabled=false;
			txtPrecio4.Enabled=false;
			txtPrecio5.Enabled=false;
			txtPrecio6.Enabled=false;
			txtPrecio7.Enabled=false;
			txtPrecio8.Enabled=false;
			txtPrecio9.Enabled=false;
			txtPrecio10.Enabled=false;
		}
		
		void BtnAñadirAlaVentaClick(object sender, EventArgs e)
		{	
			
			if(txtCodigoProducto.TextLength<9){
				int id=Convert.ToInt32(txtCodigoProducto.Text);
				pProducto=ProductoDAL.ObtenerProducto(id);//se busca el producto mediante el codigo del producto
				
				if(pProducto != null){//si el producto se encontro y no es nulo
				
				/*En este if() y en los else if() se establecen las condiciones si los campos de cada producto 
				 * que se esten agregando a la venta esten vacios agregarse en dichos campos
				 */
					if(txtCodigo1.Text=="" || txtDescripcion1.Text=="" || txtPrecio1.Text==""){
						txtCodigo1.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion1.Text=pProducto.descripcion;
						txtPrecio1.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo2.Text=="" || txtDescripcion2.Text=="" || txtPrecio2.Text==""){
						txtCodigo2.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion2.Text=pProducto.descripcion;
						txtPrecio2.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo3.Text==""||txtDescripcion3.Text==""||txtPrecio3.Text==""){
						txtCodigo3.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion3.Text=pProducto.descripcion;
						txtPrecio3.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo4.Text==""||txtDescripcion4.Text==""||txtPrecio4.Text==""){
						txtCodigo4.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion4.Text=pProducto.descripcion;
						txtPrecio4.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo5.Text==""||txtDescripcion5.Text==""||txtPrecio5.Text==""){
						txtCodigo5.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion5.Text=pProducto.descripcion;
						txtPrecio5.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo6.Text==""||txtDescripcion6.Text==""||txtPrecio6.Text==""){
						txtCodigo6.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion6.Text=pProducto.descripcion;
						txtPrecio6.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo7.Text==""||txtDescripcion7.Text==""||txtPrecio7.Text==""){
						txtCodigo7.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion7.Text=pProducto.descripcion;
						txtPrecio7.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo8.Text==""||txtDescripcion8.Text==""||txtPrecio8.Text==""){
						txtCodigo8.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion8.Text=pProducto.descripcion;
						txtPrecio8.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo9.Text==""||txtDescripcion9.Text==""||txtPrecio9.Text==""){
						txtCodigo9.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion9.Text=pProducto.descripcion;
						txtPrecio9.Text=Convert.ToString(pProducto.precio);
					}
					else if(txtCodigo10.Text==""||txtDescripcion10.Text==""||txtPrecio10.Text==""){
						txtCodigo10.Text=Convert.ToString(pProducto.codigoIdProducto);
						txtDescripcion10.Text=pProducto.descripcion;
						txtPrecio10.Text=Convert.ToString(pProducto.precio);
					}
					else{
						//si no ya no hay mas campos disponibles para agregar un producto en la venta
						MessageBox.Show("Ya no puede agregar mas productos a la venta","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					inhabilidatCamposDeTexto();
				}
			}
			else{
				MessageBox.Show("El codigo es tiene mas de 9 digitos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			txtCodigoProducto.Clear();
		}
		
		void BtnCalcularVentaClick(object sender, EventArgs e)
		{
			
			decimal resultado,precio1,precio2,precio3,precio4,precio5,precio6,precio7,precio8,precio9,precio10;
			
			/*En los if se establecen condiciones de que si los campos
 			 * del precio del producto no estan vacios que los campos de 
			 * texto del precio se convertan a decimal y se almacene a
			 * una variable de tipo decimal. Si no cumple con la condicion que el valor 
			 * sea las variables sea 0
			 */
			if(txtPrecio1.Text!=""){
				precio1=Convert.ToDecimal(txtPrecio1.Text);	
			}
			else{
				precio1=0;
			}
			if(txtPrecio2.Text!=""){
				precio2=Convert.ToDecimal(txtPrecio2.Text);
			}
			else{
				precio2=0;
			}
			if(txtPrecio3.Text!=""){
				precio3=Convert.ToDecimal(txtPrecio3.Text);
			}
			else{
				precio3=0;
			}
			if(txtPrecio4.Text!=""){
				precio4=Convert.ToDecimal(txtPrecio4.Text);
			}
			else{
				precio4=0;
			}
			if(txtPrecio5.Text!=""){
				precio5=Convert.ToDecimal(txtPrecio5.Text);
			}
			else{
				precio5=0;
			}
			if(txtPrecio6.Text!=""){
				precio6=Convert.ToDecimal(txtPrecio6.Text);
			}
			else{
				precio6=0;
			}
			if(txtPrecio7.Text!=""){
				precio7=Convert.ToDecimal(txtPrecio7.Text);
			}
			else{
				precio7=0;
			}
			if(txtPrecio8.Text!=""){
				precio8=Convert.ToDecimal(txtPrecio8.Text);
			}
			else{
				precio8=0;
			}
			if(txtPrecio9.Text!=""){
				precio9=Convert.ToDecimal(txtPrecio9.Text);	
			}
			else{
				precio9=0;
			}
			if(txtPrecio10.Text!=""){
				precio10=Convert.ToDecimal(txtPrecio10.Text);	
			}
			else{
				precio10=0;
			}
			//se calcula los precios de los productos
			resultado=precio10+precio1+precio2+precio3+precio4+precio5+precio6+precio7+precio8+precio9;
			//Se imprime el resultado en la caja de texto de la venta total
			if(resultado<=10000){
				txtVentaTotal.Text=Convert.ToString(resultado);	
			}
			else{
				MessageBox.Show("No se puede capturar una venta mayor o igual a 10000 ","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void BtnRealizarVentaClick(object sender, EventArgs e)
		{
			/*Se verifica que los campos de texto de dinero recibido y cambio no esten vacios*/
			if(txtDineroRecibido.Text!=""||txtCambio.Text!="" ){
				//se declara variables para calcular la venta total junto con el cambio
				decimal cambio,dineroRecibido,ventaTotal;
				ventaTotal=Convert.ToDecimal(txtVentaTotal.Text);
				//Si esta vacio el campo de texto dinero recibido le asignamos 0 a dinero rcibido
				if(txtDineroRecibido.Text==""){
					dineroRecibido=0;
				}
				else{// de lo contrario hacemos la convercion de texto a decimal
					dineroRecibido=Convert.ToDecimal(txtDineroRecibido.Text);	
				}
				//calculamos el cambio del dinero recibido menos la venta total
				cambio=dineroRecibido-ventaTotal;
				//mostramos en la caja de texto correspondiente el cambio
				txtCambio.Text=Convert.ToString(cambio);
				
				/*verificamos que el rango de las cajas de texto de venta total y dinero recibido
				 sean menores a los 5 dijitos*/
				if(txtVentaTotal.TextLength<5 && txtDineroRecibido.TextLength<5){
					//verificamos que el dinero recibido sea mayor a la venta total para poder realizar la venta
					if(dineroRecibido>=ventaTotal){
						//creamos un nuevo objeto de tipo venta y le establecemos sus valores
						Venta pVenta=new Venta();
						pVenta.fechaDeLaVenta=dtpFechaVenta.Value.Year + "/" + dtpFechaVenta.Value.Month + "/" + dtpFechaVenta.Value.Day;
						pVenta.nombreDeUsuarioVenta=labelNombreUsuario.Text;
						pVenta.totalDeVenta=ventaTotal;
						pVenta.dineroRecibido=dineroRecibido;
						pVenta.cambio=cambio;
						
						//asignamos a la variable resultado lo devuelva la funcion agregar(venta)
						int resultado=VentaDAL.agregar(pVenta);
						
						//comparamos si el resultado es mayor 0 e informamos si se guardo la venta o no
						if(resultado>0){
							MessageBox.Show("Se ha guardado exitosamente la venta","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
							limpiarCamposDeTexto();
						}
						else{
							MessageBox.Show("No se pudo guardar la venta","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						}
					}
					else{//en caso de que el dinero recibido es menor lo informamos
						MessageBox.Show("Introdujo un valor menor a la venta total","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
						txtCambio.Clear();
					}
				}
				else{//en caso de que la venta sea mayor a los 10,000 o de digitos de 5
					MessageBox.Show("No se puede hacer una venta mayor a 10000 pesos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
					txtCambio.Clear();
				}
				
			}
			else{//en caso de que los campos de texto esten vacios
				MessageBox.Show("No se puede realizar la venta hasta que introdusca el dinero recibido","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void limpiarCamposDeTexto(){
			txtCodigo1.Clear();
			txtDescripcion1.Clear();
			txtPrecio1.Clear();
			txtCodigo2.Clear();
			txtCodigo3.Clear();
			txtCodigo4.Clear();
			txtCodigo5.Clear();
			txtCodigo6.Clear();
			txtCodigo7.Clear();
			txtCodigo8.Clear();
			txtCodigo9.Clear();
			txtCodigo10.Clear();
			txtDescripcion2.Clear();
			txtDescripcion3.Clear();
			txtDescripcion4.Clear();
			txtDescripcion5.Clear();
			txtDescripcion6.Clear();
			txtDescripcion7.Clear();
			txtDescripcion8.Clear();
			txtDescripcion9.Clear();
			txtDescripcion10.Clear();
			txtPrecio10.Clear();
			txtPrecio1.Clear();
			txtPrecio2.Clear();
			txtPrecio3.Clear();
			txtPrecio4.Clear();
			txtPrecio5.Clear();
			txtPrecio6.Clear();
			txtPrecio7.Clear();
			txtPrecio8.Clear();
			txtPrecio9.Clear();
			txtPrecio10.Clear();
			txtCambio.Clear();
			txtDineroRecibido.Clear();
			txtVentaTotal.Clear();
		}
		
	}
}
