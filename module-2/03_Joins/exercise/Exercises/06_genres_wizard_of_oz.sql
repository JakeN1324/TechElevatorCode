-- 6. The genres of "The Wizard of Oz" (3 rows)

SELECT g.genre_name FROM movie m
JOIN movie_genre mg ON mg.movie_id = m.movie_id
JOIN genre g ON g.genre_id = mg.genre_id
WHERE m.title = 'The Wizard of Oz'
