using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
/*
 * 


/*vuelo
 * List<Pasajeros> listaP;
 * 
 * public Vuelo(char o, char d, int asientos){
 * 		listaP = new List<Pasajero>();
 * 		this.o = o;
 * 		this.d = d;
 * 		this.numAsientosDisp = asientos;
 * 		this.asientosDisp = new bool
 * }	
 * 
 * 
 * public void setPasajero(Pasajero p){
 * 	this.listaP.add(p);
 * }
*/

/*butonClick(){
if(int_32.Parse(LabelAsiento.text) != -1{
	Pasajero = new Pasajero();
}
*/



/*
*	{
* 		listaVuelos[ind].setPasajero(p);
*		listaVuelos[ind].setOcupado();
* 	}
* 