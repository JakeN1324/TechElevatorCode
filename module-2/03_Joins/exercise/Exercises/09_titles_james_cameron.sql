-- 9. The titles of movies directed by James Cameron (6 rows)

SELECT m.title FROM person p 
JOIN movie m ON m.director_id = p.person_id
WHERE p.person_name = 'James Cameron'

