export type User = {
  id: number;
  firstname: string;
  lastname: string;
  email: string;
  role: "admin" | "user"| "guest";
};
export const users: User[] = [  
    { id: 1, firstname: "Jan", lastname: "Kowalski", email: "jan.kowalski@example.com", role: "admin" },
    { id: 2, firstname: "Anna", lastname: "Nowak", email: "anna.nowak@example.com", role: "user" },
    { id: 3, firstname: "Piotr", lastname: "Wiśniewski", email: "piotr.wisniewski@example.com", role: "guest" },
    { id: 4, firstname: "Katarzyna", lastname: "Zielińska", email: "katarzyna.zielinska@example.com", role: "user" },
    { id: 5, firstname: "Marek", lastname: "Lewandowski", email: "marek.lewandowski@example.com", role: "guest" },
    { id: 6, firstname: "Alicja", lastname: "Kamińska", email: "alicja.kaminska@example.com", role: "admin" }
];
export const roles = ["admin", "user", "guest"];
export const getLastUserId = (data: User[]): number => {
    let maxId = 0;
    data.forEach(user => {
        if (user.id > maxId) {
            maxId = user.id;
        }
    });
    return maxId;
};