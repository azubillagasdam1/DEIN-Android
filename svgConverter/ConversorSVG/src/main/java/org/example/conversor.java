package org.example;

import org.apache.batik.transcoder.TranscoderInput;
import org.apache.batik.transcoder.TranscoderOutput;
import org.apache.batik.transcoder.image.PNGTranscoder;

import java.io.*;

public class conversor {
    public static void main(String[] args) {
        String contenidoSVG = "<svg width=\"280\" height=\"293\" viewBox=\"0 0 280 293\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\n" +
                // ... (tu código SVG aquí)
                "</svg>";

        // Inicializar el flujo de entrada y salida
        try (InputStream inputStream = new ByteArrayInputStream(contenidoSVG.getBytes());
             ByteArrayOutputStream outputStream = new ByteArrayOutputStream()) {

            // Configurar el transcodificador
            PNGTranscoder transcoder = new PNGTranscoder();
            TranscoderInput input = new TranscoderInput(inputStream);
            TranscoderOutput output = new TranscoderOutput(outputStream);

            // Realizar la conversión de SVG a PNG
            transcoder.transcode(input, output);

            // Guardar el PNG en un archivo si es necesario
            try (OutputStream fileOutputStream = new FileOutputStream("C:\\Users\\Aitor\\Desktop\\autobus.png")) {
                outputStream.writeTo(fileOutputStream);
            }

            System.out.println("Archivo PNG creado exitosamente.");
        } catch (Exception e) {
            System.err.println("Error al convertir SVG a PNG: " + e.getMessage());
        }
    }
}
