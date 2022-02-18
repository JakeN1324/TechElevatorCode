-- 13. The directors of the movies in the "Harry Potter Collection" (4 rows)

SELECT DISTINCT p.person_name FROM collection c
JOIN movie m ON m.collection_id = c.collection_id
JOIN person p ON p.person_id = m.director_id
WHERE c.collection_name = 'Harry Potter Collection'
