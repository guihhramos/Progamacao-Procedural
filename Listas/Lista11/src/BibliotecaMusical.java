import java.util.HashMap;
import java.util.Map;

public class BibliotecaMusical {
    private Map<String, Musica> acervo;

    public BibliotecaMusical() {
        this.acervo = new HashMap<>();
    }

    public void adicionarMusica(String titulo, Musica musica) {
        acervo.put(titulo, musica);
    }

    public void listarMusicas() {
        for (Musica musica : acervo.values()) {
            System.out.println("Título: " + musica.getTitulo());
            System.out.println("Artista: " + musica.getArtista());
            System.out.println("Álbum: " + musica.getAlbum());
            System.out.println("------------------------");
        }
    }

    public Musica buscarMusica(String titulo) throws MusicaNaoEncontradaException {
        if (acervo.containsKey(titulo)) {
            return acervo.get(titulo);
        } else {
            throw new MusicaNaoEncontradaException("Música não encontrada na biblioteca: " + titulo);
        }
    }
    public Map<String, Musica> getAcervo() {
        return acervo;
    }

    public void setAcervo(Map<String, Musica> acervo) {
        this.acervo = acervo;
    }
}
