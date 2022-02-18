-- 11. The titles of the movies in the "Star Wars Collection" ordered by release date, most recent to earliest (9 rows)

SELECT m.title FROM collection c
JOIN movie m ON m.collection_id = c.collection_id
WHERE c.collection_name = 'Star Wars Collection'
ORDER BY m.release_date DESC
