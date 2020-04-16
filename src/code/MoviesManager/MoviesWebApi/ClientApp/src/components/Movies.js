import React, { Component } from 'react';

export class Movies extends Component {
    static displayName = Movies.name;

    constructor(props) {
        super(props);
        this.state = { movies: [], loading: true };
    }

    componentDidMount() {
        this.populateMovieData();
    }

    static deleteMovie(id) {
        let path = 'api/movies/' + id;
        fetch(path, {
            method: 'DELETE',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json'
            },
        });

        window.location.reload(false);
    }

    static renderMoviesTable(movies) {
        return (
            <table id="movieTable"className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>MPAA Rating</th>
                        <th>Genre</th>
                        <th>Minutes</th>
                    </tr>
                </thead>
                <tbody>
                    {movies.map(movie =>
                        <tr key={movie.id}>
                            <td><button type="button" className="btn btn-danger btn-sm" onClick={() => this.deleteMovie(movie.id)}>X</button>{movie.id}</td>
                            <td>{movie.name}</td>
                            <td>{movie.rating}</td>
                            <td>{movie.genre}</td>
                            <td>{movie.minutes}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Movies.renderMoviesTable(this.state.movies);

        return (
            <div>
                <h1 id="tabelLabel">Our Movies</h1>
                {contents}
            </div>
        );
    }

    async populateMovieData() {
        const response = await fetch('api/movies');
        const data = await response.json();
        this.setState({ movies: data, loading: false });
    }
}
