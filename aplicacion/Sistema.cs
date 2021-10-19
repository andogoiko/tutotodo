using System.Collections.Generic;
class Sistema{

    // datos
    List<int> data = new ();

    //metodos de un lenguaje empresarial

    public int SumaDataONo(DataModel data){

        if(data.a > 7) return -3;
        if(data.SonIguales()) return 5;

        return data.a + data.b;
    }
}