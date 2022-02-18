-- 14. The names of actors who've appeared in the movies in the "Back to the Future Collection" (28 rows)

SELECT DISTINCT p.person_name FROM collection c
JOIN movie m ON m.collection_id = c.collection_id
JOIN movie_actor ma ON ma.movie_id = m.movie_id
JOIN person p ON p.person_id = ma.actor_id
WHERE c.collection_name = 'Back to the Future Collection'
