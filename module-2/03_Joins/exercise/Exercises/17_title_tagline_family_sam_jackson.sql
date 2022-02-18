-- 17. The titles and taglines of movies that are in the "Family" genre and Samuel L. Jackson has acted in (4 rows)

SELECT m.title, m.tagline FROM genre g
JOIN movie_genre mg ON mg.genre_id = g.genre_id
JOIN movie m ON m.movie_id = mg.movie_id
JOIN movie_actor ma ON ma.movie_id = m.movie_id
JOIN person p ON p.person_id = ma.actor_id
WHERE g.genre_name = 'Family' AND p.person_name = 'Samuel L. Jackson'
