///////////////////////////////////////////////////////////
//  MundoAnimal.cs
//  Implementation of the Class MundoAnimal
//  Generated by Enterprise Architect
//  Created on:      16-sep-2009 15:50:42
//  Original author: nbortolotti
///////////////////////////////////////////////////////////




public class MundoAnimal {

	private Carnivoro c;
    private Hervivoro h;

	public MundoAnimal(FactoriaContinente fc)
    {
        c = fc.CrearCarnivoro();
        h = fc.CrearHervivoro();
        
	}

	~MundoAnimal(){}

	public virtual void Dispose(){}

    public void CadenaAlimenticia()
    {
        c.Come(h);
    }

}//end MundoAnimal