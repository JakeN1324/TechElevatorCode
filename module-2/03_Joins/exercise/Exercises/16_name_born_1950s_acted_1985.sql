-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985 (20 rows)

SELECT * FROM person p
JOIN movie_actor ma ON ma.actor_id = p.person_id
JOIN movie m ON m.movie_id = ma.movie_id
WHERE p.birthday BETWEEN '1950' AND '1959' AND m.release_date = '1985'

