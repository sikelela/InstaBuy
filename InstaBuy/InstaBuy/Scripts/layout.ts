    getMeSomeServerData(someVar: string): Promise < IGenericRestResponse > {
      let headers = new Headers();
      headers.append("Content-Type", "application/json");
      let url = this.apiUrl + "getMeSomeServerData";
      let post = this.http.post(url, JSON.stringify(someVar), {
        headers: headers
      }).map(response => response.json());
      return post.toPromise();
    }