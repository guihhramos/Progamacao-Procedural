public class App {
    public static void main(String[] args) {
        Musica musica1 = new Musica("Casa de Deus", "Eli Soares", "Memórias 2");
        Musica musica2 = new Musica("Sou Humano", "Bruna Karla", "Sou Humano");
        Musica musica3 = new Musica("Ressuscita-me", "Aline Barros", "Extraordinário Amor de Deus");

        BibliotecaMusical biblioteca = new BibliotecaMusical();

        biblioteca.adicionarMusica(musica1.getTitulo(), musica1);
        biblioteca.adicionarMusica(musica2.getTitulo(), musica2);
        biblioteca.adicionarMusica(musica3.getTitulo(), musica3);

        System.out.println("Músicas disponíveis na biblioteca:");
        biblioteca.listarMusicas();

        String tituloBusca = "Ressuscita-me";
        try {
            Musica musicaEncontrada = biblioteca.buscarMusica(tituloBusca);
            System.out.println("\nDetalhes da música encontrada:");
            System.out.println("Título: " + musicaEncontrada.getTitulo());
            System.out.println("Artista: " + musicaEncontrada.getArtista());
            System.out.println("Álbum: " + musicaEncontrada.getAlbum());
        } catch (MusicaNaoEncontradaException e) {
            System.out.println(e.getMessage());
        }
    }
}
