public class Fila {

    private static Fila Instance = null;

    private Fila() {}

    public void ImprimeDocumento() {
        Console.Writeline("Imprimiu :)");
    }

    public void RemoveDocumento() {
        Console.Writeline("Removeu :(");
    }

    public void RemoveTodosDocumentos() {
        Console.Writeline("Removeu tudo 😒");
    }

    public Fila GetInstance() {
        if (Instance == null)
            Instance = new Fila();

        return Instance;
    }

}
