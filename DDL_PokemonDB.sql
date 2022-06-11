/*
CREATE TABLE Pokemon(
	Id_pokemon INTEGER primary key,
	Nombre varchar(50),
	Altura INTEGER,
    Tipo VARCHAR(12),
    Peso INTEGER,
    esChainih BIT,
    Imagen varchar(150)
)
*/

SELECT  * FROM Pokemon;

/*
INSERT INTO Pokemon (Id_pokemon, Nombre, Altura, Peso, Tipo, Imagen, esChainih)
VALUES
(1, 'Pikachu', 60, 5, 'Eléctrico', 'https://static.wikia.nocookie.net/espokemon/images/7/77/Pikachu.png', 0),
(2, 'Bullbasaur', 30, 7, 'Planta', 'https://static.wikia.nocookie.net/videojuego/images/4/43/Bulbasaur.png', 0),
(3, 'Rayquaza', 160, 200, 'Dragon', 'https://static.wikia.nocookie.net/espokemon/images/6/66/Rayquaza.png', 0),
(4, 'Mew', 30, 2, 'Psíquico', 'https://images.wikidexcdn.net/mwuploads/wikidex/thumb/b/b4/latest/20191101221107/EP1090_Mew.png/1200px-EP1090_Mew.png', 0),
(5, 'Chorizard', 200, 100, 'Choripan', 'http://pm1.narvii.com/6298/ef17f49ccd8330052e885aca157ea2d2543b048d_00.jpg', 0);
*/