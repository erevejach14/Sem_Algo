using System;
using Gtk;

namespace AlQuaedaAirlines
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}

///ventanaPrincipal
/// 
/// buttonPasajeros_Click(){
/// 	FormVuelos 
/// }


///FormPasajeros;
/// 
/// 
/// public FormPasajeros(ref List<vuelo> listaVuelos(ref ){
/// 	this.listaVuelos = listaVuelos;	
/// InitializeComponent();
/// 	actualizaListView();
/// }
/// 
/// 
/// 
/// 
/// private void actualizaListView(){
/// 	for(int i = 0; i < listaVuelos.Count; i++){
/// 		for(int j=0; j < listaVuelos.getNumPasajeros(); j++){
/// 			string [] s = new string[4];
/// 			
/// 			s[0] = i.ToString;
/// 			//s[0] = "lalala";
/// 			//s[1] = "nananna";
///		 		//s[2] = "2";
///	 		
/// 		
/// 			s[1] = listaVuelos[i].getRuta();
/// 			s[2] = listaVuelos[i].getPasajero(0).getNombre();
/// 			s[3] = listaVuelos[i].getPasajero(0).getAsiento();
/// 		}
/// 	}	
/// 	ListViewItem itm = new ListViewItem(s);
/// 	listViewPasajeros.Itenms.Add(itm);
/// 
/// 
/// 
/// 
/// }
/// 
/// 
/// private void buttonEliminar_Click(){
/// 	Console.WritenLine(listViewPasajeros.FocusedItem.Text);
/// }
/// 
/// 
/// en el disainer la lisView



///clase Vuelos
/// 
/// 
/// public string getRuta(){
/// 	return "sk1"+o+d;
/// }
/// 
/// public Pasajero getPasajero(int ind){
/// 	return this.ListaP[ind];
/// 	
/// }
/// 
/// public int getNumPasajeros(){
/// 	return ListaP.Count();
/// }



///clase Pasajeros
/// 
/// public string getNombreAp(){
/// 
/// 	return nombre + " apellido;
/// }
/// 
/// 
/// public string getAsiento(){
/// 	
/// 	return (asiento+1).ToString();
/// 
/// }