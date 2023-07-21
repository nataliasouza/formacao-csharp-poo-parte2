Banda guns = new Banda("Guns in Roses");
Album albumDoGunsInRoses = new Album("Use your ilusion I");
Genero generoRock = new Genero("Rock");

Banda metallica = new Banda("Metallica");
Album albumDoMetallica = new Album("Black Album");

Banda alok = new Banda("ALOK");
Album albumDoAlok = new Album("Annual 2021");
Genero generoBalada = new Genero("Eletrônica");

Musica musicaGNR = new Musica(guns, "November Rain",generoRock)
{
    Duracao = 538,
    Disponivel = true,
};

Musica musicaGNR2 = new Musica(guns, "Live and Let Die", generoRock)
{
    Duracao = 184,
    Disponivel = false,
};

Musica musicaMetallica = new Musica(metallica, "Nothing Else Matters", generoRock)
{
    Duracao = 368,
    Disponivel = true,
};

Musica musicaAlok = new Musica(alok, "Love Again", generoBalada) 
{
    Duracao = 237,
    Disponivel = true,
};

Musica musicaAlok2 = new Musica(alok, "Alone")
{
    Duracao = 489,
    Disponivel = true,
};

albumDoGunsInRoses.AdicionarMusica(musicaGNR);
albumDoGunsInRoses.AdicionarMusica(musicaGNR2);
guns.AdicionarAlbum(albumDoGunsInRoses);
albumDoGunsInRoses.ExibirMusicasDoAlbum();
guns.ExibirDiscografia();
musicaGNR.ExibirFichaTecnica();
musicaGNR2.ExibirFichaTecnica();
generoRock.AdicionarGeneroDaMusica(musicaGNR);
generoRock.AdicionarGeneroDaMusica(musicaGNR2);

albumDoMetallica.AdicionarMusica(musicaMetallica);
metallica.AdicionarAlbum(albumDoMetallica);
albumDoMetallica.ExibirMusicasDoAlbum();
metallica.ExibirDiscografia();
musicaMetallica.ExibirFichaTecnica();
generoRock.AdicionarGeneroDaMusica(musicaMetallica);

generoRock.ExibirMusicasPorGenero();

albumDoAlok.AdicionarMusica(musicaAlok);
albumDoAlok.AdicionarMusica(musicaAlok2);
alok.AdicionarAlbum(albumDoGunsInRoses);
albumDoAlok.ExibirMusicasDoAlbum();
alok.ExibirDiscografia();
musicaAlok.ExibirFichaTecnica();
musicaAlok2.ExibirFichaTecnica();
generoBalada.AdicionarGeneroDaMusica(musicaAlok);
generoBalada.AdicionarGeneroDaMusica(musicaAlok2);

generoBalada.ExibirMusicasPorGenero();

