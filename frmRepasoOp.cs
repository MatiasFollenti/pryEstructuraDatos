using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmRepasoOp : Form
    {
        public frmRepasoOp()
        {
            InitializeComponent();
        }

        private void cbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            string querySQL = "SELECT * FROM LIBRO";

            switch (cbOperacion.SelectedIndex) 
            {
                case 0: //UNION
                    querySQL = "SELECT * FROM LIBRO WHERE IdIdioma = 2 " +
                        "UNION " +
                        "SELECT * FROM LIBRO WHERE IdIdioma = 6 " +
                        "UNION " +
                        "SELECT * FROM LIBRO WHERE IdIdioma = 10 ";
                    lblListar.Text = "LIBROS DONDE EL IDIOMA SEA RUSO,ESPAÑOL O GRIEGO";
                    break;
                case 1: //UNION2
                    querySQL = "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE Idpais = 1 " +
                        "UNION " +
                        "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE Idpais = 5 " +
                        "UNION " +
                        "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE Idpais = 11 ";
                    lblListar.Text = "LIBROS DONDE EL PAIS SEA REINO UNIDO, ALEMANIA Y CHINA";
                    break;
                case 2:// preguntar INTERSECCION1
                    querySQL = "SELECT * FROM Libro WHERE IdIdioma < 10 AND PRECIO > 500";
                    lblListar.Text = "LIBROS DONDE EL IDIDIOMA SEA MENOR A 10 Y EL PRECIO MAYOR A 500";
                    break;
                case 3: //preguntar INTERSECCION2
                    querySQL = "SELECT * FROM Libro WHERE IdIdioma IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 9)";
                    lblListar.Text = "SELECCION DE LOS LIBROS DONDE EL IDIDIOMA SEA MENOR A 9";
                    break;
                case 4: //DIF1
                    querySQL = "select * from libro where idautor not in (select distinct idautor from libro where idautor > 10)";
                    lblListar.Text = "SELECCIONA LOS LIBROS DONDE EL IDAUTOR SEA MAYOR A 10";
                    break;
                case 5: //DIF2
                    querySQL = "select * from libro where idlibro not in (select distinct idlibro from libro where idlibro > 7) ";
                    lblListar.Text = "SELECCIONA LOS LIBROS DONDE EL IDAUTOR NO SEA MAYOR A 7";
                    break;
                case 6: //SELEC SIMPLE 1
                    querySQL = "select idlibro, titulo, cantidad from libro where cantidad = 5 ";
                    lblListar.Text = "SELECCIONA CAMMPOS IDLIBRO,TITULO,CANTIDAD DONDE LA CANTIDAD SEA 5";
                    break;
                case 7: //Select SIMPLE2
                    querySQL = "select titulo, precio from libro where idlibro = 12";
                    lblListar.Text = "seleciona de los libros su titulo y precio";
                    break;
                case 8: //SELEC MULTIA POR INTERSEC
                    querySQL = "SELECT * FROM LIBRO WHERE CANTIDAD < 10 AND PRECIO > 500";
                    lblListar.Text = "SELECCIONA LIBROS DONDE EL PRECIO ES MAYOR A 500";
                    break;
                case 9: //SELEC MULTIA POR INTERSEC
                    querySQL = "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE IDPAIS < 5 AND CANTIDAD > 2";
                    lblListar.Text = "SELECCIONA TITULO,AÑO Y PRECIO DONDE EL IDPAIS ES MENOR A 5 Y LA CANTIDAD MAYOR A 2";
                    break;
                case 10://SELEC MULTIA X CONVOLUSION
                    querySQL = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdPais > 5) as T2 WHERE T2.IdAutor < 10";
                    lblListar.Text = "selecciona los libros donde idPais es mayor a 5 y idAutor menor a 10";
                    break;
                case 11://SELEC MULTIA X CONVOLUSION
                    querySQL = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.cantidad > 5) as T2 WHERE T2.precio < 300";
                    lblListar.Text = "selecciona libros donde cantidad es mayor a 5 y precio menor a 300";
                    break;
                case 12:
                    querySQL = "select idlibro, titulo, idautor, precio from libro order by precio desc";
                    lblListar.Text = "Ordena los libros de mayor a menor segun el precio";
                    break;
                case 13:
                    querySQL = "select idlibro, titulo, idautor, precio, cantidad from libro order by cantidad asc";
                    lblListar.Text = "Ordena los libros de menor a mayor segun su cantidad";
                    break;
                case 14:
                    querySQL = "select titulo from libro";
                    lblListar.Text = "Muestra los nombres de los libros";
                    break;
                case 15:
                    querySQL = "select idlibro from libro";
                    lblListar.Text = "Muestra los libros registrados";
                    break;
                case 16:
                    querySQL = "select titulo,precio,cantidad from libro";
                    lblListar.Text = "Muestra el nombre, el precio y la cantidad del libro";
                    break;
                case 17:
                    querySQL = "select idlibro,titulo,año from libro";
                    lblListar.Text = "Muestra el cod. de indentificacion del libro, ademas de el nombre y el año en el que salió";
                    break;
                case 18:
                    querySQL = "SELECT * FROM Libro, Autor WHERE LIBRO.IDAUTOR = AUTOR.IDAUTOR";
                    lblListar.Text = "Muestra el ID de cada autor de cada libro";
                    break;
                case 19:
                    querySQL = "select * from libro, idioma where libro.ididioma = idioma.ididioma";
                    lblListar.Text = "Muestra el idioma de cada libro segun sus ID";
                    break;

            }

            bd.Listar(dgvBaseDatosRepasoOperaciones,querySQL);
        }
    }
}
