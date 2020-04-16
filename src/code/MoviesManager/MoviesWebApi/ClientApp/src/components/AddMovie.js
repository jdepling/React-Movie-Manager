import React, { Component } from 'react';
import { Movies } from './Movies';

export class AddMovie extends React.Component {
    static displayName = AddMovie.name;
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            genre: "",
            rating: "",
            minutes: 0
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleInputChange(event) {
        const target = event.target;
        const value = target.value;
        const name = target.name;

        this.setState({
            [name]: value
        });
    }

    handleSubmit(event) {
        event.preventDefault();

        var data = JSON.stringify({
            name: this.state.name,
            rating: this.state.rating,
            genre: this.state.genre,
            minutes: Number(this.state.minutes)
        });

        
        fetch('api/movies', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json'
            },
            body: data
        });

        document.getElementById("form").reset();
    }

  render () {
    return (
        <div class="container">
            <h1>Add a movie</h1>
            <form id="form" ref={(el) => this.myFormRef = el} onSubmit={this.handleSubmit}>
                <div class="form-group">
                    <label for="name">Name of movie:
                        <input
                            name="name"
                            type='text'
                            value={this.state.name}
                            class="form-control"
                            id="name"
                            onChange={this.handleInputChange} />
                        </label>
                </div>

                <div class="form-group">
                    <label for="genre">Genre:
                        <input
                            class="form-control"
                            name="genre"
                            id="genre"
                            onChange={this.handleInputChange} />
                        </label>
                </div>

                <div class="form-group">
                    <label for="rating">MPAA Rating:
                        <input
                            class="form-control"
                            id="rating"
                            name="rating"
                            onChange={this.handleInputChange} />
                        </label>
                </div>

                <div class="form-group">
                    <label for="minutes">Minutes:
                        <input
                            class="form-control"
                            id="minutes"
                            name="minutes"
                            onChange={this.handleInputChange} />
                        </label>
                </div>
                
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>

      </div>
    );
  }
}
