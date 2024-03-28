
class Shape
{
    private string _color;

    public Shape(string  color){
        this._color = color;
    }

    public string GetColor(){
        return this._color;
    }

    public void SetColor(string color){
        this._color = color;
    }

    public virtual double GetArea(){
        return 0.00;
    }
}