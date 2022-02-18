-- 2. The names and birthdays of actors in "The Fifth Element" (15 rows)

SELECT p.person_name, p.birthday FROM movie m
JOIN movie_actor ma ON ma.movie_id = m.movie_id
JOIN person p ON p.person_id = ma.actor_id
WHERE m.title = 'The Fifth Element'

