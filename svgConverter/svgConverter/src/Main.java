import org.apache.batik.transcoder.TranscoderInput;
import org.apache.batik.transcoder.TranscoderOutput;
import org.apache.batik.transcoder.image.PNGTranscoder;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        // Código SVG como una cadena
        String contenidoSVG = "<svg width=\"280\" height=\"293\" viewBox=\"0 0 280 293\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\n" +
                "<path d=\"M0 215.895C0 229.465 6.825 241.648 17.5 250.129V277.579C17.5 286.061 25.375 293 35 293H52.5C62.125 293 70 286.061 70 277.579V262.158H210V277.579C210 286.061 217.875 293 227.5 293H245C254.625 293 262.5 286.061 262.5 277.579V250.129C273.175 241.648 280 229.465 280 215.895V61.6842C280 7.71053 217.35 0 140 0C62.65 0 0 7.71053 0 61.6842V215.895ZM61.25 231.316C46.725 231.316 35 220.984 35 208.184C35 195.385 46.725 185.053 61.25 185.053C75.775 185.053 87.5 195.385 87.5 208.184C87.5 220.984 75.775 231.316 61.25 231.316ZM218.75 231.316C204.225 231.316 192.5 220.984 192.5 208.184C192.5 195.385 204.225 185.053 218.75 185.053C233.275 185.053 245 195.385 245 208.184C245 220.984 233.275 231.316 218.75 231.316ZM245 138.789H35V61.6842H245V138.789Z\" fill=\"white\"/>\n" +
                "</svg>\n";

        // Ruta del archivo PNG de salida
        String rutaArchivoPNG = "C:\\Users\\Aitor\\Desktop\\autobus.svg";

        try (InputStream inputStream = new ByteArrayInputStream(codigoSVG.getBytes());
             OutputStream outputStream = new FileOutputStream(rutaArchivoPNG)) {

            // Configurar el transcodificador
            PNGTranscoder transcoder = new PNGTranscoder();
            TranscoderInput input = new TranscoderInput(inputStream);
            TranscoderOutput output = new TranscoderOutput(outputStream);

            // Realizar la conversión de SVG a PNG
            transcoder.transcode(input, output);

            System.out.println("Archivo PNG creado exitosamente.");
        } catch (Exception e) {
            System.err.println("Error al convertir SVG a PNG: " + e.getMessage());
        }
    }
}
