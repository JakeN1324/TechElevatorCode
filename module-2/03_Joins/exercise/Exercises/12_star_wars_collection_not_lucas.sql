-- 12. The titles of the movies in the "Star Wars Collection" that weren't directed by George Lucas (5 rows)

SELECT m.title FROM collection c
JOIN movie m ON m.collection_id = c.collection_id
JOIN person p ON p.person_id = m.director_id
WHERE p.person_name != 'George Lucas' AND c.collection_name = 'Star Wars Collection'
