using System.Drawing;

namespace Display.SDK
{
    /// <summary>
    /// Bizim plug-in'lerimizin amacı nedir ve kullanıcılar nasıl ayırt ederler? 
    /// </summary>
    public interface IPlug
    {
        string Name { get; }
        void Draw(Graphics graphic, SolidBrush solidBrush, int x, int y, int width, int height);
    }
}
