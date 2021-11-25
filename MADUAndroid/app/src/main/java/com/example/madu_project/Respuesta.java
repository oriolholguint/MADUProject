package com.example.madu_project;

public class Respuesta
{
    private String respuesta;
    private boolean esCorrecta;

    public Respuesta(String respuesta, boolean esCorrecta)
    {
        this.respuesta = respuesta;
        this.esCorrecta = esCorrecta;
    }

    public String getRespuesta() {
        return respuesta;
    }

    public boolean isEsCorrecta() {
        return esCorrecta;
    }

    public void setRespuesta(String respuesta) {
        this.respuesta = respuesta;
    }

    public void setEsCorrecta(boolean esCorrecta) {
        this.esCorrecta = esCorrecta;
    }

    @Override
    public String toString()
    {
        return "Respuesta{" +
                "Respuesta='" + respuesta + '\'' +
                ", EsCorrecta=" + esCorrecta +
                '}';
    }
}
